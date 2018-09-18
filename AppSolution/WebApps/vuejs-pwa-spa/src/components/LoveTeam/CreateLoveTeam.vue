<template>
    <div>
        <h3 class="title is-3">Create Love Team</h3>
        <hr />
        <div class="columns">
            <div class="column">
                <div class="field">
                    <label class="label">Name Of Boy</label>
                    <div class="control">
                        <input type="text" class="input" placeholder="e.g. John" v-model="loveTeam.nameOfBoy"/>
                    </div>
                </div>
                <div class="field">
                    <label class="label">Name of Girl</label>
                    <div class="control">
                                               <input type="text" class="input" placeholder="e.g. Jessy" v-model="loveTeam.nameOfGirl"/>
                    </div>
                </div>
            </div>
            <div class="column">
                <div class="field">
                    <label class="label">Anniversary Date</label>
                    <div class="control">
                        <input type="date" class="input"  v-model="loveTeam.anniversaryDate" />
                    </div>
                </div>
            </div>
        </div>
        <button class="button is-success" @click="create">Create</button>
        &nbsp;
        <router-link to="/loveteams/" class="button">Go back</router-link>
    </div>
</template>

<script>
import axios from 'axios'
export default {
    data(){
        return{
            loveTeam: {}
        }
    },
    methods:{
        create(){
            axios.post('loveteams', this.loveTeam).then(response=>{
                alert(response.data.result)
                this.loveTeam = {};
            }).catch(error=>{
                console.log(error);
            });
        }
    }
}
</script>
