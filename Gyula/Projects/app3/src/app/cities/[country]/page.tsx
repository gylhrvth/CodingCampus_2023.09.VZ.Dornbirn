import { getCitiesByCountry } from "@/app/utils"
import { RowDataPacket } from "mysql2"


export default async function Cities({ params }: { params: { country: string } }) {
    let country = decodeURI(params.country)
    const cities : RowDataPacket[] = await getCitiesByCountry(country)
    const listCitiesComponents = 
        cities.map((value, index) => 
            <p key={index}
                className={`group rounded-lg border border-transparent px-5 py-4 transition-colors hover:border-gray-300 hover:bg-gray-100 hover:dark:border-neutral-700 hover:dark:bg-neutral-800/30`}
            >
                {value['Name']}<br/>{' '}
                <span className="inline-block transition-transform group-hover:translate-x-1 motion-reduce:transform-none">
              -&gt;
                </span>{' '}
                in {value['Province']}
            </p>) 

    return (
        <>
        <h2 className="mb-3 text-2xl font-semibold text-orange-400">Cities in {country}</h2>
        <div className="mb-32 grid text-center lg:max-w-5xl lg:w-full lg:mb-0 lg:grid-cols-5 lg:text-left">

            {listCitiesComponents}
        </div>
        </>
    )}