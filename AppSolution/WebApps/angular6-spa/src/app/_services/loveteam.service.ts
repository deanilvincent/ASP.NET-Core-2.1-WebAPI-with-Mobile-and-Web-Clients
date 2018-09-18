import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoveTeam } from '../_models/loveTeam';
import { environment } from '../../environments/environment';

@Injectable()
export class LoveteamService {

constructor(private http: HttpClient) { }

getLoveTeams(): Observable<LoveTeam[]> {
    return this.http.get<LoveTeam[]>(`${environment.ApiUrl}loveteams/`);
}

}
