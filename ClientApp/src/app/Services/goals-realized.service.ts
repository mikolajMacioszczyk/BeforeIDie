import {Inject, Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {IGoal} from "../Models/IGoal";

@Injectable({
  providedIn: 'root'
})
export class GoalsRealizedService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  public getAll(): Observable<any>{
    return this.http.get<IGoal[]>(this.baseUrl+"api/realized");
  }

  public getById(id: number): Observable<any>{
    return this.http.get<IGoal>(this.baseUrl + "api/realized/" + id);
  }

  public delete(id: number): Observable<any>{
    return this.http.delete(this.baseUrl + "api/realized/" + id);
  }

  public update(id: number, item: IGoal): Observable<any>{
    return this.http.put<IGoal>(this.baseUrl + "api/realized/" + id, item);
  }
}
