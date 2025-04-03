

const API_URL = "http://localhost:5087/api/Students/passed";

async function getPassedStudents() {
    try {
        const response = await fetch(API_URL);
        return await response.json();
    } catch (error) {
        console.error("Error fetching students:", error);
    }
}



