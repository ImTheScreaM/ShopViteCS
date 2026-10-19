import { type RouteConfig, index,route,layout } from "@react-router/dev/routes";

export default [
	layout("routes/layout.tsx", [
		index("routes/home.tsx"),
		route("product", "routes/product.tsx"),
		route("basket", "routes/basket.tsx")
	]),
	route("login", "routes/login.tsx"),
	route("*","routes/not_found.tsx")

] satisfies RouteConfig;
