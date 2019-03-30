import React, { useState } from 'react';
import './ContactForm.css';

const ContactForm = props => {
    const [name, setName] = useState("");
    const [email, setEmail] = useState("");
    const [message, setMessage] = useState("");

    const handleSubmit = event => {
        event.preventDefault();
    }

    return (
      <form 
      className="contact-form"
      onSubmit={handleSubmit}>
        <input
            value={name}
            onChange={e => setName(e.target.value)}
            placeholder="Name"
            type="text"
            name="name"
            required
            />
            <input
            value={email}
            onChange={e => setEmail(e.target.value)}
            placeholder="Email"
            type="email"
            name="email"
            required
            />
            <input
            value={message}
            onChange={e => setMessage(e.target.value)}
            placeholder="Enter your message here."
            type="text"
            name="message"
            required
            />
            <button type="submit">Submit</button>
      </form>
    );
}

export default ContactForm;