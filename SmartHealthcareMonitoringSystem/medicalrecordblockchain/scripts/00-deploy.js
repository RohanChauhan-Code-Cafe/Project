const { ethers } = require("hardhat");
async function main() {
  console.log("Deploying smart contract...");
  const Medical = await ethers.getContractFactory("MedicalRecords");
  const account = await ethers.getSigners();
  const medical = await Medical.connect(account[1]).deploy();
  //await medical.deployed();
  await medical.waitForDeployment();
  //console.log(`${medical.address}`);
  console.log(`Medical is deployed in address: ${medical.target}`);

  

}
main()
  .then(() => process.exit(0))
  .catch((error) => {
    console.log(error);
    process.exit(1);
  });
