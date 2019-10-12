// JavaScript source code
import React from 'react';

class DBComponent extends React.Component {
    constructor(props) {
        console.log("DBComponent.constructor()");

        super(props);
        this.state = { pakkaus: [] };
    }

    componentDidMount() {
        console.log("DBComponent.componentDidMount()");

        let reactKomponentti = this;
        fetch('https://localhost:44398/api/pakkaus')
            .then(response => response.json())
            .then(json => {
                console.log("pakkaus0-data ladattu.");

                reactKomponentti.setState({ pakkaus: json });

            });

        console.log("Fetch-kutsu tehty.")

    }

    render() {
        console.log("Oma.render()");

        let lkm = this.state.pakkaus.length;
        var taulukko = [];
        for (let index = 0; index < lkm; index++) {
            let pakkaus = this.state.pakkaus[index];

            taulukko.push(<tr>
                <td>{pakkaus.pakkausnro}</td>
                <td>{pakkaus.kauppaantulopvm}</td>
                <td>{pakkaus.laakenimi}</td>
            </tr>);
        }

        return <div>
            <table>
                <thead>
                    <tr>
                        <th>Pakkausnro</th>
                        <th>MAdate</th>
                        <th>Nimi</th>
                    </tr>
                </thead>
                <tbody>
                    {taulukko}
                </tbody>

            </table>

        </div>;
    }
}
export default DBComponent;