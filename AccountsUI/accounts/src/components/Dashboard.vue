<template>
<div class="customer-list">
    <table>
    <!-- table header omitted for brevity -->
    <thead>
      <tr>
        <th>Customer ID</th>
        <th>Name</th>
        <th>Account No</th>
        <th>Message</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="(account, index) in accounts" :key="index">
        <td>{{ account.customerID }}</td>
        <td>{{ account.name }}</td>
        <td>{{ account.accountNo }}</td>
        <td>{{ account.message }}</td>
      </tr>
    </tbody>
  </table>
</div>
</template>

<script>
import axios from 'axios'
export default {
    data(){
    return {
      accounts: [],
      }
    },
    async mounted(){
    await axios.get("http://localhost:43509/api/Customer/Gets1").then(response=>{
      console.log(response);
      // debugger
      this.accounts = response.data;
    }).catch(error => {
      console.error(error);
    });
   
  },

        
}
</script>

<style scoped>
.customer-list
{
    margin: 20px;
}
table{
    border-collapse: collapse;
    width: 100%;
    margin-bottom: 20px;
}
thead{
    color: #000000;
    background-color: #6666ff;
    
}
th {
    text-align: left;
    padding: 8px;
    border-bottom: 1px solid #001a00;
}
td {
    text-align: left;
    padding: 8px;
    border-bottom: 1px solid #ddd;
}
tr:hover{
    background-color: #99ffff;
}
</style>