import React, { Component } from 'react';
import './ContactUsPage.css';
import ContactForm from '../../components/ContactForm/ContactForm';

const ContactUsPage = props => {
    return (
      <div className="contact-us">
        <ContactForm />
      </div>
    );
}

export default ContactUsPage;