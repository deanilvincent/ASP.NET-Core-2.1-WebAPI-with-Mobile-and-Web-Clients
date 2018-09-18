<template>
    <div>
        <h3 class="title is-3">List of Love Teams</h3>
        <hr />
        <button class="button is-success" @click="refresh">Refresh</button>
        &nbsp;
        <router-link to="/loveteams/create" class="button">Create new</router-link>
        <table class="table is-bordered is-striped is-narrow is-hoverable is-fullwidth">
        <thead>
            <th>Love Team ID</th>
            <th>Name Of Boy</th>
            <th>Name Of Girl</th>
            <th>Anniversary Date</th>
            <th></th>
        </thead>
        <tbody>
            <tr v-for="loveTeam in loveTeams">
                <td>{{loveTeam.loveTeamId}}</td>
                <td>{{loveTeam.nameOfBoy}}</td>
                <td>{{loveTeam.nameOfGirl}}</td>
                <td>{{loveTeam.anniversaryDate}}</td>
                <td>
                    <button class="button is-link" @click="navToEdit(loveTeam.loveTeamId)">Edit</button>
                    &nbsp;
                    <button class="button is-danger" @click="deleteLoveTeam(loveTeam.loveTeamId)">Delete</button>
                </td>
            </tr>
        </tbody>
        </table>
    </div>
</template>

<script>
import {mapState,mapActions} from 'vuex'
import axios from 'axios'

export default {
   computed:{
       ...mapState({
           loveTeams: state=>state.loveTeams
       })
   },
   methods:{
       ...mapActions([
           "getLoveTeams"
       ]),
       refresh(){
           this.getLoveTeams();
       },
       navToEdit(id){
           this.$router.push("/loveteams/edit/"+id)
       },
       deleteLoveTeam(id){
           axios.delete(`loveteams/${id}`).then(response=>{
               alert(response.data.result);
               this.getLoveTeams();
           }).catch(error=>{
               console.log(error)
           })
       }
   },
   created(){
       this.getLoveTeams();
   }
}
</script>
