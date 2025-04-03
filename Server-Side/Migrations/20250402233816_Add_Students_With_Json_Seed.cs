using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace firstRest.Migrations
{
    /// <inheritdoc />
    public partial class Add_Students_With_Json_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Grade", "Name" },
                values: new object[,]
                {
                    { new Guid("03bb102d-88bd-46d5-adad-1b1dc2c521d9"), 18, 54.4m, "Laila Salem" },
                    { new Guid("043cb9e0-7a65-45ac-85aa-126d09eb3db7"), 18, 65.97m, "Noor Nasser" },
                    { new Guid("055d3426-5a06-4308-8134-ac1bc4d8055f"), 21, 84.28m, "Khaled Ibrahim" },
                    { new Guid("06ea0a00-afa7-46a2-987a-03b3fe9bc81b"), 22, 56.14m, "Ahmed Hussein" },
                    { new Guid("086493f2-2e35-4feb-b83d-668b430fb388"), 19, 97.69m, "Laila Salem" },
                    { new Guid("0d87083b-e768-4733-a707-0de92413062d"), 25, 67.19m, "Ali Salem" },
                    { new Guid("0e1a3ad2-5aed-442d-849a-4c9be5e3e8f3"), 25, 84.84m, "Omar Ibrahim" },
                    { new Guid("0ea8126e-2c60-4cc8-898c-e8dfdf15c153"), 23, 91.16m, "Omar Hussein" },
                    { new Guid("0ecb042b-36f4-4a8b-a1be-c4a2505ef53f"), 23, 81.63m, "Omar Saeed" },
                    { new Guid("10317f7e-9cee-4ceb-9071-e04ecfc1b5a1"), 22, 76.72m, "Sara Gad" },
                    { new Guid("11a4196c-096c-4be4-9cfa-cb5a941c0762"), 19, 87.21m, "Ali Mohamed" },
                    { new Guid("13a32ac1-16da-42bf-9a5c-2dff0a53a479"), 22, 60.22m, "Youssef Fahmy" },
                    { new Guid("141e5358-f415-47cf-9ab8-364fe71e7f77"), 24, 64.37m, "Laila Ibrahim" },
                    { new Guid("14b82471-f7b5-4806-971d-503ef578e68e"), 22, 90.3m, "Sara Tawfik" },
                    { new Guid("1537c84e-240c-4677-9f1e-8c779d31c8c7"), 25, 71.04m, "Ahmed Saeed" },
                    { new Guid("1554a860-47fa-4aa8-b3a2-585f0c09239b"), 23, 55.39m, "Ali Gad" },
                    { new Guid("16d24042-a4ed-46fb-ada9-6b4343414fb5"), 19, 89.76m, "Youssef Mohamed" },
                    { new Guid("188e8acb-fb3b-42b3-a7f4-e20d84bd4ea4"), 23, 51.15m, "Ali Hussein" },
                    { new Guid("19c2e364-7b57-4768-9a59-3bcf3601c921"), 25, 90.42m, "Hassan Fahmy" },
                    { new Guid("1a560fb3-a2fc-41a8-bd0f-28aa4f6e1e2d"), 22, 53.46m, "Omar Ismail" },
                    { new Guid("22474dab-1b95-433d-881a-9e47559bc5f3"), 19, 85.57m, "Omar Salem" },
                    { new Guid("2296f4c2-64d3-4e1b-a2e3-d9cc25cc7045"), 20, 68.06m, "Hassan Gad" },
                    { new Guid("2942a691-c02d-4762-9107-e6b06e614441"), 25, 87.95m, "Omar Hussein" },
                    { new Guid("2bb2a712-5467-4fe4-b215-6b6f99d06c5b"), 24, 71.61m, "Youssef Nasser" },
                    { new Guid("2e6fc1c4-4bcb-4d4b-838e-be7464d3a4bd"), 20, 77.2m, "Ahmed Ibrahim" },
                    { new Guid("2fdfb4c7-1742-47cf-bd52-7d6ba9aa03cb"), 20, 76.69m, "Ahmed Mohamed" },
                    { new Guid("33cb1c61-ce7c-4110-9f08-6875b1d2939d"), 20, 69.96m, "Omar Salem" },
                    { new Guid("34be3919-3635-434b-91d5-b7da059842d7"), 24, 62.14m, "Khaled Gad" },
                    { new Guid("34ef0afe-729d-4d68-9535-6605b51e1db7"), 23, 83.14m, "Sara Fahmy" },
                    { new Guid("3514c2fd-f667-4f05-a758-4b6f3c836000"), 24, 74.81m, "Laila Salem" },
                    { new Guid("355da79f-daf2-413d-950d-53d4110539b3"), 22, 73.93m, "Laila Tawfik" },
                    { new Guid("36cb9cd5-6005-406e-b08f-84c7525393b3"), 23, 87.88m, "Ali Saeed" },
                    { new Guid("39217bba-eabf-4508-a9b2-b0ac3c53fa0c"), 25, 84.45m, "Sara Saeed" },
                    { new Guid("3947251c-fa71-40b8-a7ec-bdf2f7513219"), 19, 50.33m, "Youssef Ismail" },
                    { new Guid("3a8bbe3e-bff8-4ebd-98c7-3a891c1e6b19"), 21, 96.74m, "Hassan Fahmy" },
                    { new Guid("3c9cd972-33f5-4355-987f-f144d63068f0"), 19, 81.79m, "Ali Fahmy" },
                    { new Guid("41039cea-5299-4a7e-93ef-e175025de39d"), 20, 50.34m, "Noor Hussein" },
                    { new Guid("42cf7a61-b692-4213-9a7b-66ffe1bcb3eb"), 21, 58.32m, "Ali Ibrahim" },
                    { new Guid("440e42fc-1a1d-4b65-8358-169bb1c71dd5"), 19, 83.53m, "Ali Ismail" },
                    { new Guid("453527e2-2458-46a0-b197-c13dc524e31c"), 24, 59.99m, "Hassan Salem" },
                    { new Guid("4554745f-092a-4311-a451-475220a44f83"), 20, 56.05m, "Khaled Ismail" },
                    { new Guid("45d48c42-d1c3-4b68-ba23-ab90868292fc"), 23, 73.27m, "Laila Hussein" },
                    { new Guid("48e03ca0-e198-4f41-b6c4-152143906bc5"), 19, 73.73m, "Khaled Saeed" },
                    { new Guid("4b6ef335-0fd5-4ec9-bbf8-020943b12517"), 19, 65.97m, "Khaled Hussein" },
                    { new Guid("4ea99ace-c5a2-4ca3-b748-0094a40d8207"), 23, 99.86m, "Mona Fahmy" },
                    { new Guid("4f6f0dff-e472-42d1-a43c-e367829944eb"), 23, 66.88m, "Ahmed Mohamed" },
                    { new Guid("51e5342f-b275-481d-a15b-216cb27b1c48"), 23, 65.81m, "Khaled Tawfik" },
                    { new Guid("529ce3a5-5838-4924-9ff7-4720acf47e01"), 18, 83.0m, "Omar Ismail" },
                    { new Guid("5a01d982-0586-431b-aea5-c58bbbc89aa5"), 19, 52.88m, "Hassan Salem" },
                    { new Guid("610fbec5-638d-4a32-9e73-4b30044011a2"), 21, 90.04m, "Khaled Salem" },
                    { new Guid("62d47d1c-03c5-4bf8-95f5-e17849360f00"), 21, 94.81m, "Sara Hussein" },
                    { new Guid("6758b305-826c-4916-b0cf-55b88946624e"), 25, 79.03m, "Hassan Ismail" },
                    { new Guid("6b0bc1a6-4c48-4b29-bdd8-6f73bb69f949"), 21, 91.41m, "Ali Saeed" },
                    { new Guid("6c1a8f5a-b390-4131-ba25-40f517fbeedd"), 20, 77.05m, "Sara Nasser" },
                    { new Guid("6ee4fba6-f091-448a-a69f-b430b99fac6d"), 21, 97.78m, "Ali Mohamed" },
                    { new Guid("6f77abc2-6afb-4d11-aba3-49fc66cf5060"), 24, 78.19m, "Sara Nasser" },
                    { new Guid("701fa799-6714-4b43-ad72-852e4f0d43d6"), 19, 87.03m, "Omar Mohamed" },
                    { new Guid("703e5f7c-d560-4893-8e06-29ea95884c48"), 19, 77.94m, "Khaled Fahmy" },
                    { new Guid("728420a8-df81-4a8b-9298-994fdb958313"), 20, 77.06m, "Khaled Gad" },
                    { new Guid("72d2df13-c26f-4fff-8e61-5177de29f2bb"), 23, 64.37m, "Omar Ibrahim" },
                    { new Guid("73736082-e04d-400e-9e33-cd4581284ae5"), 24, 62.46m, "Youssef Salem" },
                    { new Guid("7512b915-e2bb-4b51-af61-4ede72f892a3"), 19, 50.33m, "Sara Ismail" },
                    { new Guid("784f7ef8-e8c7-4714-ba2b-cbde020a6de5"), 23, 95.15m, "Omar Salem" },
                    { new Guid("7b90d271-ae48-4492-9643-9536d50c07d6"), 19, 90.59m, "Sara Saeed" },
                    { new Guid("7d53d4b6-1480-46ac-8748-356bc9f60830"), 18, 58.71m, "Laila Ibrahim" },
                    { new Guid("7d5a0874-cd49-4e46-8c07-a3d6c397f4f6"), 23, 72.72m, "Hassan Saeed" },
                    { new Guid("7dc192c9-ddc7-4f8f-94d9-073277ed9a00"), 21, 52.56m, "Omar Ismail" },
                    { new Guid("7f9c5598-545b-450e-abb5-3104e5caabf3"), 22, 85.51m, "Youssef Salem" },
                    { new Guid("7fac6293-7dc8-4a3c-b8fe-9ecb042cfc51"), 22, 86.81m, "Ali Ibrahim" },
                    { new Guid("7fb1c3a0-446d-4932-b044-b5571b2bb99b"), 21, 93.39m, "Sara Mohamed" },
                    { new Guid("823aac75-3a1f-4164-ba45-0c4e6e3523c8"), 24, 78.52m, "Omar Saeed" },
                    { new Guid("82f6664f-8cc9-483f-abb2-701f904655a8"), 25, 64.48m, "Hassan Mohamed" },
                    { new Guid("86a85e62-a030-4156-85df-07920149318e"), 18, 56.74m, "Sara Ismail" },
                    { new Guid("8868a7bd-f5a4-4b4b-a92a-b591e847ca11"), 18, 64.8m, "Youssef Nasser" },
                    { new Guid("8be8a216-7e27-45b6-bbac-9dccc6625698"), 20, 86.4m, "Ali Ibrahim" },
                    { new Guid("8dff5ba2-7608-462b-b6a7-03d7a1db266d"), 18, 53.05m, "Omar Ibrahim" },
                    { new Guid("8e0e2e08-ce69-4961-97cf-28a8ce796520"), 25, 80.31m, "Mona Salem" },
                    { new Guid("917c3785-6f98-4617-a5db-36f8588275db"), 19, 52.39m, "Hassan Nasser" },
                    { new Guid("919020c7-f058-4f82-aefa-597d269b7dc7"), 24, 83.94m, "Noor Hussein" },
                    { new Guid("91a9c206-849b-4320-94ae-d8f47266cbde"), 21, 94.89m, "Noor Salem" },
                    { new Guid("91b2347f-7a74-4e76-8965-5d56dcb5b5c8"), 22, 70.77m, "Laila Tawfik" },
                    { new Guid("94e6a95b-1dcb-43ca-9542-f0c0f4be1c78"), 25, 89.51m, "Mona Ibrahim" },
                    { new Guid("97ff82b0-1a8f-42b5-a3e4-703bf5e9815f"), 21, 97.08m, "Youssef Gad" },
                    { new Guid("9890edac-6339-46ff-bb1e-3564d0609798"), 25, 51.51m, "Noor Gad" },
                    { new Guid("999afa9d-7cc3-4aa7-ab2d-19520f30edc1"), 18, 58.05m, "Ali Saeed" },
                    { new Guid("99cdde86-9a44-40e2-b9ab-9f0f4742edc3"), 25, 80.95m, "Mona Hussein" },
                    { new Guid("9f063552-5459-4a2c-8cf8-1bb7453d7c55"), 19, 59.87m, "Laila Ibrahim" },
                    { new Guid("9f760151-730e-4066-9912-e0d79abfff15"), 23, 65.24m, "Ahmed Nasser" },
                    { new Guid("a0f2d56f-205d-423e-951b-b887a3db0682"), 21, 78.86m, "Noor Nasser" },
                    { new Guid("a4062d45-eb9e-49d8-ac6f-c6e1de7ce056"), 25, 54.5m, "Ali Salem" },
                    { new Guid("a5465482-948a-48a0-aa08-59b649db1d9f"), 19, 91.62m, "Youssef Ibrahim" },
                    { new Guid("a5c0a046-ad07-4d80-8d3e-7a46618f2fe3"), 21, 59.81m, "Omar Mohamed" },
                    { new Guid("a767ed89-46f7-4cf9-a7fe-143f37f602e5"), 20, 86.77m, "Ahmed Ismail" },
                    { new Guid("aa54111a-ee76-4a70-a6d7-49fa1417c988"), 24, 84.95m, "Omar Saeed" },
                    { new Guid("abcb76d1-51df-458a-9c74-578681f0f9ea"), 22, 62.94m, "Omar Fahmy" },
                    { new Guid("ad075ccf-04cd-4d55-b990-a05389f60963"), 20, 63.71m, "Noor Nasser" },
                    { new Guid("add3d76d-4359-46d9-b453-abddfeb04909"), 21, 74.6m, "Ahmed Mohamed" },
                    { new Guid("ade9efeb-c5e7-4171-ab6d-9c4253f6db40"), 24, 64.51m, "Youssef Saeed" },
                    { new Guid("b13a80db-01ea-49f4-8a18-b194a1aa0510"), 21, 72.33m, "Laila Saeed" },
                    { new Guid("b1e83397-63ae-4802-acb7-a3d3da9af5bb"), 21, 77.3m, "Ahmed Ibrahim" },
                    { new Guid("b227543c-1553-4e55-a5c1-1cff5197d127"), 25, 95.14m, "Youssef Hussein" },
                    { new Guid("b31eb6c4-9154-4144-a953-483adb11bda3"), 23, 60.5m, "Youssef Gad" },
                    { new Guid("b4d202e5-bf02-4ea6-a0ec-f4846f1cec6f"), 20, 50.11m, "Khaled Hussein" },
                    { new Guid("bb184b99-3cdf-4043-ba42-6a0bf8255acf"), 24, 73.57m, "Sara Ibrahim" },
                    { new Guid("bdac6488-4e41-4aac-9769-c57d0bc9f215"), 24, 63.61m, "Sara Mohamed" },
                    { new Guid("be741d8f-ef6a-4e9c-916b-402f9e39574f"), 25, 73.42m, "Ahmed Ibrahim" },
                    { new Guid("c095f959-5bae-43da-af24-407333af6424"), 19, 90.24m, "Noor Ismail" },
                    { new Guid("c13e4a9d-cdc6-4b65-840b-2ad5a651126e"), 25, 88.4m, "Noor Ibrahim" },
                    { new Guid("c15059a3-0666-4ee7-abc5-93145e8ce261"), 24, 78.59m, "Laila Saeed" },
                    { new Guid("c1ae59ed-d4fe-44ae-98f6-96f998f42809"), 20, 93.01m, "Mona Ismail" },
                    { new Guid("c24033ce-1157-4dd4-a8ab-b2de5636446d"), 25, 98.37m, "Mona Saeed" },
                    { new Guid("c2846923-e332-4ed1-8c52-75e4207c2247"), 24, 62.72m, "Laila Tawfik" },
                    { new Guid("c3fccf6c-ded9-43a1-8eae-b55078c7a22f"), 25, 83.26m, "Khaled Gad" },
                    { new Guid("c684afdb-d53f-4c4e-a792-da5a4554c493"), 25, 92.64m, "Mona Nasser" },
                    { new Guid("c6a0e4a8-54a4-4811-a226-d448841bc659"), 20, 67.9m, "Noor Hussein" },
                    { new Guid("c8473a23-5285-4a0b-a703-a95505cc373f"), 22, 78.01m, "Mona Mohamed" },
                    { new Guid("c9c91b70-b626-4a40-8d50-d0564ce82b5f"), 19, 97.71m, "Sara Ismail" },
                    { new Guid("c9e4eeda-acfb-46cf-b4fa-a18583dd36d7"), 23, 82.59m, "Mona Hussein" },
                    { new Guid("ca66767f-62ab-46f6-8f12-831b182c3267"), 18, 76.63m, "Sara Salem" },
                    { new Guid("ca950405-494a-481e-952d-e81057ab53eb"), 20, 75.49m, "Ali Ismail" },
                    { new Guid("ccb81913-1b99-4050-a565-5e9b6dd2754e"), 20, 76.5m, "Ali Nasser" },
                    { new Guid("cfed1125-6568-48ee-89d0-e0cd762f32cf"), 23, 56.0m, "Youssef Salem" },
                    { new Guid("d3dbb944-8550-4ec1-93b7-64e668b0cff9"), 20, 82.66m, "Omar Tawfik" },
                    { new Guid("d50c7cf1-6c98-4287-abb5-27b12ed559a6"), 20, 70.23m, "Khaled Ismail" },
                    { new Guid("d69e2796-cdb4-4f9f-b549-a54800df7208"), 22, 54.34m, "Ahmed Saeed" },
                    { new Guid("d8332380-f3ab-4577-bead-09c064b7450f"), 18, 58.48m, "Laila Fahmy" },
                    { new Guid("d9c8a064-2af2-4f9c-b193-51b864b5279a"), 24, 63.95m, "Ahmed Gad" },
                    { new Guid("dbb24c43-3457-4571-8077-1eabb750609d"), 21, 54.37m, "Ali Hussein" },
                    { new Guid("dd3b6cbc-0e2d-405b-a2b6-2aec1113cb0b"), 18, 62.24m, "Mona Nasser" },
                    { new Guid("de3a1215-e9b0-4f51-aca6-0e0837407269"), 25, 98.92m, "Youssef Salem" },
                    { new Guid("de43f780-49ed-4be9-a0e7-359c9ce4afde"), 19, 93.56m, "Omar Tawfik" },
                    { new Guid("e05e97a3-46a0-42a4-8b80-160fa15f2152"), 23, 99.22m, "Youssef Mohamed" },
                    { new Guid("e2333d13-b75c-4a68-8636-dde57877d212"), 23, 98.2m, "Laila Ismail" },
                    { new Guid("e25c2b36-e30f-4c74-a7b7-b7753fd6ecbf"), 22, 86.23m, "Laila Nasser" },
                    { new Guid("e3a9bd8a-2464-4e3a-bf59-9b39a19de3f5"), 25, 78.46m, "Ahmed Nasser" },
                    { new Guid("e3f1681c-5620-4844-b7bb-e847497afee1"), 19, 77.94m, "Mona Mohamed" },
                    { new Guid("e8093800-4772-43e4-b282-56cd1aa69520"), 22, 72.8m, "Ahmed Salem" },
                    { new Guid("e9334d1f-2c67-4b3e-a231-e59a0be4b583"), 20, 78.45m, "Ahmed Salem" },
                    { new Guid("eaecde00-f222-47d0-9db1-21cbe1b424db"), 23, 61.37m, "Omar Mohamed" },
                    { new Guid("ed5cfda8-e925-4c08-82d7-18f39a5acc4d"), 20, 71.06m, "Ali Fahmy" },
                    { new Guid("edd4d812-9fdd-4264-8262-70da7721a89a"), 21, 80.67m, "Laila Tawfik" },
                    { new Guid("ee840c60-136d-4e4f-b8a1-d75046fadd3d"), 25, 78.83m, "Laila Ismail" },
                    { new Guid("ef46f0cc-ca70-4972-bf8d-6277a0b6314e"), 20, 90.14m, "Khaled Nasser" },
                    { new Guid("f255e278-88b8-4d02-9f45-b8bad00afc28"), 23, 74.96m, "Mona Gad" },
                    { new Guid("f70ac03f-1d3e-46ae-80f2-119d811ec107"), 23, 57.74m, "Youssef Mohamed" },
                    { new Guid("f9ce4fcd-a86f-4907-ae1f-92e29cc69a42"), 20, 86.41m, "Laila Ismail" },
                    { new Guid("fb40aeaf-2b33-47b7-aa2d-60e67a4ebeac"), 23, 71.08m, "Ali Ismail" },
                    { new Guid("fd3fb50a-0788-474c-8f41-e641247178d6"), 21, 92.74m, "Mona Salem" },
                    { new Guid("ff12401c-9f10-4fcb-b9a9-789f228e8bbd"), 18, 91.18m, "Ali Gad" },
                    { new Guid("ff93dd74-4ccc-49b1-9e43-985c5b3b482a"), 23, 57.46m, "Ahmed Mohamed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
