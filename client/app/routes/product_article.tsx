import type { Route } from "./+types/product_article"
import { ProductArticlePage } from "~/pages/product_article_page";

export async function loader({params}: Route.LoaderArgs) {
	const baseUrl = process.env.VITE_API_URL || import.meta.env.VITE_API_URL;
	const res = await fetch(`${baseUrl}/products/${params.id}`);
	
	if (!res.ok) {
		throw new Response("Error",{status:res.status,statusText:res.statusText} )
	}
	return await res.json();
}

export default function ProductArticle({loaderData}:Route.ComponentProps) {
	return <ProductArticlePage data={loaderData} />
}