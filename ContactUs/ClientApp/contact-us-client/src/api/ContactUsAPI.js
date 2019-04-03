
const postMessage = async ({ name, email, message }) => {
    const messageData = {
        senderName: name,
        emailAddress: email,
        message
    }

    const apiUrl = "/api/ContactUs"
    const fetchOptions = {
        method: "POST",
        mode: "cors",
        cache: "no-cache",
        credentials: "same-origin",
        headers: {
            "Content-Type": "application/json",
        },
        redirect: "follow",
        referrer: "no-referrer",
        body: JSON.stringify(messageData)
    }

    const response = await fetch(apiUrl, fetchOptions);

    const result = await response.json();

    return result;

}

export default postMessage