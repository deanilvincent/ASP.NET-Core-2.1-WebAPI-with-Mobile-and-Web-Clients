import { Component, OnInit } from '@angular/core';
import { LoveteamService } from '../../_services/loveteam.service';
import { LoveTeam } from '../../_models/loveTeam';

@Component({
  selector: 'app-list-of-loveteams',
  templateUrl: './list-of-loveteams.component.html',
  styleUrls: ['./list-of-loveteams.component.css']
})
export class ListOfLoveteamsComponent implements OnInit {

  loveTeams: any = [];

  constructor(private loveTeamService: LoveteamService) { }

  ngOnInit() {
    this.getLoveTeams();
  }

  refresh(){
    this.getLoveTeams();
  }

  getLoveTeams() {
    this.loveTeamService.getLoveTeams().subscribe((response: any) => { 
      this.loveTeams = response.result;
    }, error => {
      console.log(error);
    });
  }

}
