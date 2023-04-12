import { User } from "../auth/viewModels";
import { Board } from "../board/viewModels";

export class Item {

    constructor(public id: number,
        public name: string,
        public description: string,
        public state: ItemState,
        public createdBy: User,
        public assignedTo: User,
        public board: Board,
        public parentItem: Item | undefined,
        public subItems: Array<Item> | undefined) {
    }
}

export enum ItemState {
    OnHold = 1,
    ToDo = 2,
    InProgress = 3,
    Done = 4,
    Rejected = 5,
}

export class CreateItemViewModel {

    constructor(public userId: number, 
                public boardId: number,
                public name: string) {
    }
}

export class CreateItemResultViewModel {

    constructor(public isCreated: boolean,
                public createdItem: Item | null) {
    }
}

export class ChangeItemResultViewModel {

    constructor(public isChanged: boolean,
                public item: Item | null) {
}
}

export class ChangeItemStateViewModel {

    constructor(public userId: number, 
                public boardId: number,
                public itemId: number,
                public newState: ItemState) {
}
}

