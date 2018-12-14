import React, { Component } from 'react';
import { MonitoringService } from '../../services/MonitoringService';

export class Monitor extends Component {
    displayName = Monitor.name;
    _monitoringService;

	constructor(props) {
        super(props);
        this.state = {
            items: []
        };
	}

	componentDidMount() {
        this._monitoringService = new MonitoringService(this.props.websocketService, (data) => { this.handleNewData(data);});
    }

    handleNewData(data) {
        this.setState({
            items: data
        });
    }

    render()
    {
        return <div>{this.state.items.map(item => <div>{item.name} - {item.price}</div>)}</div>;
	}
}