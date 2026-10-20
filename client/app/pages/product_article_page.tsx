import type { IProductData } from "~/shared/types";

export function ProductArticlePage({ data }: { data: IProductData }) {

	return (
		<div>
			<div className="flex flex-wrap justify-center gap-10 p-10">
				<div className="grid">
					<div>
						<img src={`${data.imageUrl}`} alt="img" width={250} />
					</div>
					<div className="flex justify-around">
						<div className="grid">
							<span>{data.name}</span>
							<span>{data.brand}</span>
						</div>
						<div>
							<span>{data.price}</span>
						</div>
					</div>
				</div>
			</div>
		</div>
	);
}
