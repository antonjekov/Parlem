export class Product {
  constructor(
    public _id: number,
    public productName: string,
    public productTypeName: string,
    public numeracioTerminal: string,
    public soldAt: string,
    public customerId: number) {}
}
