import React from 'react';
import { Navbar, Nav } from 'react-bootstrap';
import './App.css';
import ContactUsPage from './containers/ContactUsPage/ContactUsPage';

const App = props => {
    return (
      <div className="App">
      <Navbar bg="dark" expand="lg">
  <Navbar.Brand href="/">Yourname.com</Navbar.Brand>
  <Navbar.Toggle aria-controls="basic-navbar-nav" />
  <Navbar.Collapse id="basic-navbar-nav">
    <Nav className="mr-auto">
      <Nav.Link href="">Home</Nav.Link>
      <Nav.Link className="active" href="">Contact</Nav.Link>
    </Nav>
  </Navbar.Collapse>
</Navbar>
        <ContactUsPage />
      </div>
    );
}

export default App;
