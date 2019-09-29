import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StartpageComponent } from './components/startpage/startpage.component';
import { ContestComponent } from './components/contest/contest.component';
import { VictoryComponent } from './components/victory/victory.component';

const routes: Routes = [
  { path: "home", component: StartpageComponent },
  { path: "contest", component: ContestComponent },
  { path: "victory", component: VictoryComponent },
  { path: "**", pathMatch: "full", redirectTo: "home" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
