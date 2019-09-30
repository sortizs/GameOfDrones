import { Component, OnInit } from '@angular/core';
import { Winner } from 'src/app/entities/winner';
import { PlayerService } from 'src/app/services/player.service';
import { Player } from 'src/app/entities/player';

@Component({
  selector: 'app-contest',
  templateUrl: './contest.component.html',
  styleUrls: ['./contest.component.scss']
})
export class ContestComponent implements OnInit {

  round = 0;
  score1 = 0;
  score2 = 0;
  username1: string;
  username2: string;
  players: any[];

  constructor(private playerService: PlayerService) {  }

  ngOnInit() {
    this.getPlayerList();
    console.log(this.players);
  }

  getPlayerList(){
    this.playerService
    .getPlayers()
    .subscribe((data:any) => {
      this.players = data;
    });
  }
}
