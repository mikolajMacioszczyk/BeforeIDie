import {Inject, Injectable} from '@angular/core';
import {Observable} from "rxjs";
import {HttpClient} from "@angular/common/http";
import {IGoal} from '../Models/IGoal';

@Injectable({
  providedIn: 'root'
})
export class GoalsPlannedService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  public getAll(): Observable<any>{
    return this.http.get<IGoal[]>(this.baseUrl+"api/planned");
  }

  public getById(id: number): Observable<any>{
    return this.http.get<IGoal>(this.baseUrl + "api/planned/" + id);
  }

  public create(item: IGoal): Observable<any>{
    return this.http.post<IGoal>(this.baseUrl+"api/planned", item);
  }

  public delete(id: number): Observable<any>{
    return this.http.delete(this.baseUrl + "api/planned/" + id);
  }

  public update(id: number, item: IGoal): Observable<any>{
    return this.http.put<IGoal>(this.baseUrl + "api/planned/" + id, item);
  }

  public updateStatus(id: number, status: number): Observable<any>{
    return this.http.patch(this.baseUrl + "api/planned/"+id, status);
  }
}
