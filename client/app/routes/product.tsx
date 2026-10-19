import { ProductsPage } from "~/pages/product_page";
import type { Route } from "./+types/product"

export async function loader({ params }: Route.LoaderArgs) {
	const baseUrl = process.env.VITE_API_URL || import.meta.env.VITE_API_URL;
	const res = await fetch(`${baseUrl}/products`);
	return res.json()
}

export default function Product({loaderData}: Route.ComponentProps) {
	return <ProductsPage data={loaderData} />
}