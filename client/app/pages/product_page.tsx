import { NavLink } from "react-router";
import type { IProductData } from "~/shared/types";

export function ProductsPage({ data }: { data: IProductData[] }) {
	return (
		<div className="flex flex-wrap justify-center gap-10 p-10">
			{data.map((i) => (
				<NavLink key={i.id} to={`/product/article/${i.id}`}>
					<div className="grid" >
						<div>
							<img src={`${i.imageUrl}`} alt="img" width={250} />
						</div>
						<div className="flex justify-around">
							<div className="grid">
								<span>{i.name}</span>
								<span>{i.brand}</span>
							</div>
							<div>
								<span>{i.price}</span>
							</div>
						</div>
					</div>
				</NavLink>
			))}
		</div>
	);
}
