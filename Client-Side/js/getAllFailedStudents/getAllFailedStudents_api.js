
const API_URL = "http://localhost:5087/api/Students/failed";

async function getFailedStudents() {
    try {
        const response = await fetch(API_URL);
        return await response.json();
    } catch (error) {
        console.error("Error fetching students:", error);
    }
}
