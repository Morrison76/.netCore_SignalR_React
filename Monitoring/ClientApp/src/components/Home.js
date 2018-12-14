import React, { Component } from 'react';
import MonitoringWebsocketService  from '../services/WebsocketService';
import { Monitor } from './home/Monitor';

export class Home extends Component {
	displayName = Home.name;
	websocketService = null;

	constructor(props) {
		super(props);
        this.websocketService = new MonitoringWebsocketService ();
	}

	render() {
		return <div className='row'>
			<div className='col-sm-8'>
                <Monitor websocketService={this.websocketService} />
			</div>
		</div>;
	}
}