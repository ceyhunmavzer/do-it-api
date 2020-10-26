import * as DataModels from "@datamodels"

export interface User {
    name: string;
    lastName: string;
    address: string;
    postalCode: string;
    country: string;
    personalGreeting: string;
}

export default User;