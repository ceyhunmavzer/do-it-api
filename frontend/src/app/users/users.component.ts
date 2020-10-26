import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import * as Api from "@api";
import * as DataModels from "@datamodels";

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  users: DataModels.User[];
  displayedColumns: string[] = ['name', 'lastName', 'address', 'postalCode', 'country', 'personalGreeting'];

  constructor(private httpClient: HttpClient) { }

  async ngOnInit() {
    const paging: DataModels.QueryPagination = {
      pageIndex: 0,
      pageSize: 20
    };
    this.users = (await Api.UserAPI.listUsers(this.httpClient, paging)).items;
    console.log(this.users);
  }
}
