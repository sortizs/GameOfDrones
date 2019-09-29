import { Component, OnInit } from '@angular/core';
import { Winner } from 'src/app/entities/winner';
import { PlayerService } from 'src/app/services/player.service';

@Component({
  selector: 'app-contest',
  templateUrl: './contest.component.html',
  styleUrls: ['./contest.component.scss']
})
export class ContestComponent implements OnInit {

  round = 0;
  score1 = 0;
  score2 = 0;
  players: any[] = [];
  error: string;

  constructor(private player: PlayerService) {
    this.player.getPlayers().subscribe((data: any) => {
      this.players = data;
    }, (err) =>{
      this.error = err;
      console.log(this.error);
    }
    );
  }

  ngOnInit() {
  }

}
