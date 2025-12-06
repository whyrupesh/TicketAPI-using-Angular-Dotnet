import { Component, OnInit } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { Ticket } from '../../models/ticket.model';
import { TicketService } from '../../services/ticket.service';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-ticket-list',
    standalone: true,
    imports: [CommonModule, DatePipe],
    templateUrl: './ticket-list.component.html',
    styleUrls: ['./ticket-list.component.css']
})
export class TicketListComponent implements OnInit {
    tickets$!: Observable<Ticket[]>;

    constructor(private ticketService: TicketService) { }

    ngOnInit(): void {
        this.tickets$ = this.ticketService.getTickets();
    }
}
