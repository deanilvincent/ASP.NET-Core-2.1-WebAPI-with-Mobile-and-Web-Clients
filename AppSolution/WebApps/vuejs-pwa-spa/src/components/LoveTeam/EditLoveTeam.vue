<template>
    <div>
        <h3 class="title is-3">Edit Love Team</h3>
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
        <button class="button is-success" @click="update">Update</button>
        &nbsp;
        <router-link to="/loveteams/" class="button">Go back</router-link>
    </div>
</template>

<script>
import {mapState,mapActions} from 'vuex'
import moment from 'moment'
import axios from 'axios'

export default {
    data(){
        return{
            loveTeam: {}
        }
    },
    computed:{
        ...mapState({
            loveTeamById: state=>state.loveTeamById
        })
    },
    methods:{
        ...mapActions([
            "getLoveTeamById"
        ]),
        update(){
            axios.put(`loveteams/${this.$route.params.id}`,this.loveTeam).then(response=>{
                alert(response.data.result);
            }).catch(error=>{
                console.log(error);
            })
        }
    },
    created(){
        this.getLoveTeamById({
            loveTeamId: this.$route.params.id
        })
    },
    watch:{
        loveTeamById(){
            if(this.loveTeamById){
                this.loveTeam = this.loveTeamById;
                this.loveTeam.anniversaryDate = moment(this.loveTeamById.anniversaryDate).format('YYYY-MM-DD');
            }
        }
    }
}
</script>
