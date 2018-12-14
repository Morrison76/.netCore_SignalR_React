import React, { Component } from 'react';
import { NavMenu } from './NavMenu';

export class Layout extends Component {
  displayName = Layout.name

	render() {
        return <div>
            <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

			<NavMenu />
			<div className='container-fluid'>
				{this.props.children}
			</div>
		</div>;
  }
}
