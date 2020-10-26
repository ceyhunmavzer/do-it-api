import * as DataModels from "@datamodels"

export interface Pagination<T> {
    items: T[],
    count: number,
    pageIndex: number,
    pageSize: number,
}

export default Pagination;