const API_URL_AVG = "http://localhost:5087/api/students/average";

// Get Elements
const averageDialog = document.getElementById("averageDialog");
const averageValue = document.getElementById("averageValue");
const closeDialogBtn = document.getElementById("closeDialogBtn");
const goButton = document.querySelector(".btn.average"); // Select the "Go" button

// Fetch and Show Dialog with Average Grade
async function getStudentsAverageGrade() {
  try {
    const response = await fetch(API_URL_AVG);
    if (!response.ok) {
      throw new Error("Failed to fetch data");
    }

    const data = await response.json();
    averageDialog.classList.toggle("hide");
    averageValue.textContent = `Average Grade: ${data.average.toFixed(2)}`;
    averageDialog.showModal();
  } catch (error) {
    console.error("Error in getStudentsAverageGrade():", error);
    averageValue.textContent = "Failed to load data.";
    averageDialog.showModal(); // Show error message in dialog
  }
}

// // Attach Event Listener to "Go" Button
goButton.addEventListener("click", getStudentsAverageGrade);

// Close Dialog
closeDialogBtn.addEventListener("click", () => {
  averageDialog.close();
  averageDialog.classList.toggle("hide");
  
});
