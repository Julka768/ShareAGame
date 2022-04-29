import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SelectOption } from '../models/select-options';

@Injectable({
  providedIn: 'root',
})
export class PublishersService {
  constructor(private http: HttpClient) {}
  getAllPublusherSelectOptions(): Observable<SelectOption[]> {
    return this.http
      .get<SelectOption[]>(
        'https://localhost:44352/Publisher/GetAllSelectOptions'
      )
      .pipe();
  }
}
