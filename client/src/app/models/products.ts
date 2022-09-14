export interface Product {
    id: number;
    name: string;
    descrition: string;
    price: number;
    pictureUrl: string;
    type?: string;
    brand: string;
    quantityInStock?: number;
}