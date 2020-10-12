import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-dream-blackquote',
  templateUrl: './dream-blackquote.component.html',
  styleUrls: ['./dream-blackquote.component.css']
})
export class DreamBlackquoteComponent implements OnInit {
  @Input('text') text: string;
  @Input('author') author: string;

  constructor() { }

  ngOnInit() {
  }

}
