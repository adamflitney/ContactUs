import React, { useState } from 'react';
import './ContactForm.css';

const ContactForm = props => {
    const [name, setName] = useState("");
    const [email, setEmail] = useState("");
    const [message, setMessage] = useState("");

    const handleSubmit = event => {
        event.preventDefault();
        console.log(props);
        props.submitHandler({name, email, message});
        setName("");
        setEmail("");
        setMessage("");
    }

    return (
        <form
            className="contact-form"
            onSubmit={handleSubmit}>

            <div className="form-group">
                <label htmlFor="contactFormName">Name</label>
                <input
                    id="contactFormName"
                    className="form-control"
                    value={name}
                    onChange={e => setName(e.target.value)}
                    placeholder="e.g. Joe Bloggs"
                    type="text"
                    name="name"
                    required
                />
            </div>
            <div className="form-group">
                <label htmlFor="contactFormEmail">Email Address</label>
                <input
                    id="contactFormEmail"
                    className="form-control"
                    value={email}
                    onChange={e => setEmail(e.target.value)}
                    placeholder="e.g. joe@bloggs.com"
                    type="email"
                    name="email"
                    required
                />
            </div>
            <div className="form-group">
                <label htmlFor="contactFormMessage">Enter your message</label>
                <textarea
                    id="contactFormMessage"
                    className="form-control"
                    value={message}
                    onChange={e => setMessage(e.target.value)}
                    placeholder="Enter your message here."
                    type="text"
                    rows="4"
                    name="message"
                    required
                ></textarea>
            </div>
            <button id="submit-btn" type="submit" className="btn btn-success">Submit</button>
        </form>
    );
}

export default ContactForm;