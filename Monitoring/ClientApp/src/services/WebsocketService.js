import * as signalR from "@aspnet/signalr";

class MonitoringWebsocketService {
	_connection = null;

	constructor() {
        let url = `${document.location.protocol}//${document.location.host}/monitoring`;
		this._connection = new signalR.HubConnectionBuilder()
			.withUrl(url)
            .build();

        this._connection.start().then(() => {
            this._connection.invoke("Data");
        }).catch(err => document.write(err));
	}

	registerInformationAdded(informationAdded) {
		// get other client chat message from the server
        this._connection.on('informationAdded', (data) => {
            informationAdded(data);
		});
	}
}
export default MonitoringWebsocketService;