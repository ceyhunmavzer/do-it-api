import * as DataModels from "@datamodels"
import { HttpClient } from '@angular/common/http';

export const UserAPI = {
    async listUsers(httpClient: HttpClient, query?: DataModels.QueryPagination): Promise<DataModels.Pagination<DataModels.User>> {
        let queryString = "";
        if (query) {
            queryString = Object.keys(query).map(key => key + '=' + query[key]).join('&');
        }
        return await httpClient.get<DataModels.Pagination<DataModels.User>>(`/api/users?${queryString}`).toPromise();
    },
};

export default UserAPI;