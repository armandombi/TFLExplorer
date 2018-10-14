import React from 'react';
import Navbar from './Navbar';
import Jumbotron from './Jumbotron';

export default class Theme extends React.Component {
	render() {
		return (
			<div>
				<Navbar />
				<Jumbotron />
			</div>);
	}
}