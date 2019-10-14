import React from 'react'

class Pagination extends React.Component {
    render() {
        let items = [];
        for (let number = 1; number <= 10; number++) {
            items.push(
                <Pagination.Item>{number}</Pagination.Item>
            );
        }
        return <Pagination bsSize="small">{items}</Pagination>

    }