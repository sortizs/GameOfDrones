export class Player {
    private _username: string;
    public get username(): string {
        return this._username;
    }
    public set username(v: string) {
        this._username = v;
    }

    constructor(json: any) {
        this.username = json.username;
    }
}