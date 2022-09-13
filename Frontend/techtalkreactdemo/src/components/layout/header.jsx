import React from 'react';
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';


export default function Header() {
    return (
        < >
            <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark">
                <Container>
                    <Navbar.Brand href="#home">TechTalkReactJSDemo</Navbar.Brand>


                    <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                    <Navbar.Collapse id="responsive-navbar-nav">
                        <Nav className="me-auto">
                            <Nav.Link href="/">Home</Nav.Link>
                            <Nav.Link href="#pricing">Catholic Content</Nav.Link>

                            <NavDropdown title="Administration" id="collasible-nav-dropdown">
                                <NavDropdown.Item href="/view-customer">Customer Directory </NavDropdown.Item>
                                <NavDropdown.Item href="#action/3.2">Staff Directory </NavDropdown.Item>
                                <NavDropdown.Item href="#action/3.3">User Right</NavDropdown.Item>
                                <NavDropdown.Divider />
                                <NavDropdown.Item href="">
                                    User Details
                                </NavDropdown.Item>
                                <NavDropdown.Item href="">
                                    User Role
                                </NavDropdown.Item>
                            </NavDropdown>
                            <NavDropdown title="React JS Demo" id="collasible-nav-dropdown">
                                <NavDropdown.Item href="/view-use-state">Use State </NavDropdown.Item>
                                <NavDropdown.Item href="/view-use-effect">Use Effect </NavDropdown.Item>

                            </NavDropdown>



                        </Nav>


                        <Nav>
                            <Nav.Link href="#deets">More deets</Nav.Link>
                            <Nav.Link eventKey={2} href="#memes">
                                Welcome Dear, Admin
                            </Nav.Link>
                        </Nav>
                    </Navbar.Collapse>
                </Container>
            </Navbar>

        </>
    );
}

