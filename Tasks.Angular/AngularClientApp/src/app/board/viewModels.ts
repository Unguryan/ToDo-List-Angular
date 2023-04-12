import { User } from "../auth/viewModels";
import { Item } from "../items/viewModels";

export class Board {

    constructor(public id: number,
                public name: string,
                public owner: User,
                public sharedUsers: Array<User>,
                public items: Array<Item>) {
    }
}

export class GetUserBoardsResultViewModel {

    constructor(public boards: Array<Board> | undefined) {
    }
}

export class CreateBoardViewModel {

    constructor(public userId: number, 
                public name: string) {
    }
}

export class CreateBoardResultViewModel {

    constructor(public createdBoard: Board) {
    }
}

export class GetUserBoardByIdResultViewModel {

    constructor(public isFound: boolean,
                public board: Board) {
    }
}




