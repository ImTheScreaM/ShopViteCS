export interface IProductData {
	id?: number;
	category: string;
	brand: string;
	imageUrl: string;
	price: number;
	name: string;
}

export interface IDataRegisterAuth extends IDataLoginAuth {
	userName: string;
	age: number;
}

export interface IDataLoginAuth {
	email: string;
	password: string;
}