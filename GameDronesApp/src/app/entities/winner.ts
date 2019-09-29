export class Winner {
    private _username: number;
    private _score : number;
    private _rounds : number;

    public get username(): number {
        return this._username;
    }
    public set username(v: number) {
        this._username = v;
    }

    public get score() : number {
        return this._score;
    }

    public set score(v : number) {
        this._score = v;
    }
    
    public get rounds() : number {
        return this._rounds;
    }
    
    public set rounds(v : number) {
        this._rounds = v;
    }  

    constructor(json: any) {
        this.username = json.username;
        this._score = json.score;
        this._rounds = json.rounds;
    }
}