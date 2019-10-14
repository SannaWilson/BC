import React from 'react';
import Pagination from "react-js-pagination";


class DBComponent extends React.Component {
    constructor(props) {
        console.log("DBComponent.constructor()");
        super(props);
        this.state = {
            kaikki: [],
            activePage: 1,
            itemsCountPerPage: 20
        };
        this.handlePageChange = this.handlePageChange.bind(this);
    }

    handlePageChange(pageNumber) {
        console.log(`active page is ${pageNumber}`);
        this.setState({ activePage: pageNumber });
    }

   

    componentDidMount() {
        console.log("DBComponent.componentDidMount()");

        let reactKomponentti = this;
        fetch('https://localhost:44398/api/pakkaus')
            .then(response => response.json())
            .then(json => {
                console.log("pakkaus0-data ladattu.");

                reactKomponentti.setState({ kaikki: json });
            });

        console.log("Fetch-kutsu tehty.")
    }

    render() {
        console.log("DBComponent.render()");

        let lkm = this.state.kaikki.length;
        var taulukko = [];
        for (let index = 0; index < lkm; index++) {
            let tuote = this.state.kaikki[index];

            let lopetusIndeksi = this.state.activePage + this.state.itemsCountPerPage;
            let aloitusIndeksi = lopetusIndeksi - this.state.itemsCountPerPage;

            if (index < aloitusIndeksi) {
                continue;
            }
            if (index > lopetusIndeksi) {
                continue;
            }

            taulukko.push(<tr>
                <td>{tuote.laakenimi}</td>
                <td>{tuote.atckoodi}</td>
                <td>{tuote.kaupan}</td>
            </tr>);
        }

        return <div>

            <Pagination
                activePage={this.state.activePage}
                itemsCountPerPage={20}
                totalItemsCount={lkm}
                pageRangeDisplayed={0}
                onChange={this.handlePageChange} />

            <table className="table table sm">
                <thead>
                    <tr>
                        <th>Brändi</th>
                        <th>ATC-koodi</th>
                        <th>hum</th>
                    </tr>
                </thead>
                <tbody>
                    {taulukko}
                </tbody>
            </table>

        </div>
    }
}
export default DBComponent;