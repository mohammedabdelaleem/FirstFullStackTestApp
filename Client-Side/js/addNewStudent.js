// Dialog
// Get Elements
const addedDialog = document.getElementById("addedDialog");
const addedValue = document.getElementById("addedValue");
const closeDialogBtn = document.getElementById("closeDialogBtn");
const goButton = document.querySelector(".btn.average"); // Select the "Go" button

// Handling form submission
document
  .getElementById("studentForm")
  .addEventListener("submit", async function (event) {
    event.preventDefault();

    // Collect form data
    const studentData = {
      name: document.getElementById("name").value,
      age: document.getElementById("age").value,
      grade: document.getElementById("grade").value,
    };

    try {
      // Sending POST request to add a new student
      const response = await fetch("http://localhost:5087/api/students/add", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(studentData),
      });

      // Check for successful creation
      if (response.status === 201) {
        const data = await response.json();
        console.log(data);

        addedDialog.classList.toggle("remove");
        addedDialog.classList.remove("invalid");

        addedValue.textContent = `Student Added Successfuly With Id: ${data.id}`;
        addedDialog.showModal();
      } else {

        const errorData = await response.json();

        addedDialog.classList.toggle("remove");
        addedDialog.classList.add("invalid");

        addedValue.textContent = `Error: ${
          errorData.message || "Invalid data"
        }`;
        addedDialog.showModal();
      }
    } catch (error) {
      // console.error("Error:", error);
      addedValue.textContent = "Failed to load data.";
      addedDialog.showModal(); // Show error message in dialog
    }
  });

// Close Dialog
closeDialogBtn.addEventListener("click", () => {

if(!addedDialog.classList.contains("invalid")){
  //Empty Form
  document.getElementById("name").value = "";
  document.getElementById("age").value = "";
  document.getElementById("grade").value = "";
}else {

}

  addedDialog.close();
  addedDialog.classList.toggle("remove");
});
