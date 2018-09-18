import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    loveTeams: [],
    loveTeamById: {}
  },
  mutations: {
    getLoveTeams: (state) => {
      axios.get(`loveteams`).then(response=>{
        state.loveTeams = response.data.result;
      }).catch(error => {
        console.log(error);
      })
    },
    getLoveTeamById:(state,payload) =>{
      axios.get(`loveteams/${payload.loveTeamId}`).then(response=>{
        state.loveTeamById = response.data.result;
      }).catch(error=>{
        console.log(error);
      })
    }
  },
  actions: {
    getLoveTeams: ({commit}) =>{
      commit('getLoveTeams')
    },
    getLoveTeamById:({commit},payload) =>{
      commit('getLoveTeamById',payload)
    }
  }
})
