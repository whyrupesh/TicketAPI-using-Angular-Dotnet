export interface Ticket {
    id: number;
    shortDescription: string;
    description: string;
    createdDate: Date;
    severity: string;
    targetDate: Date;
    status: string;
}
