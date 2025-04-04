
// 01 - store API URL
// stores the endpoint for fetching all students. 
const API_URL = "http://localhost:5087/api/Students/all";

// 02 - is an asynchronous function that uses the fetch() API to make a GET request 
// to the backend. It waits for the response and then converts it to JSON format.
//  If an error occurs during the fetch, it logs the error message.
 async function getStudents() {
    try {
        const response = await fetch(API_URL);
        return await response.json();
    } catch (error) {
        console.error("Error fetching students:", error);
    }
}
