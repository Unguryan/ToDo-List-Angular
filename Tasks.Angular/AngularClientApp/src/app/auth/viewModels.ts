export class LoginByTelegramResultViewModel {

    constructor(public url: string,
                public key: string) {
    }
}

export class LogoutViewModel {

    constructor(public token: string,
                public userId: number) {
    }
}

export class LogoutResultViewModel {

    constructor(public isSuccess: boolean) {
    }
}


export class TokenDataModel {
    public token: string;
    public id: number;
    public name: string;
    public telegramId: string;
    public gitHubUsername: string;
    public username: string;
    public expired: Date;
}

export class User {
    public id: number;
    public name: string;
    public telegramId: string;
    public gitHubUsername: string;
    public username: string;
}