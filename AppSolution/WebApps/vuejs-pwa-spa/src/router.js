import Vue from 'vue'
import Router from 'vue-router'
import ListOfLoveTeam from '../src/components/LoveTeam/ListOfLoveTeam.vue'
import CreateLoveTeam from '../src/components/LoveTeam/CreateLoveTeam.vue'
import EditLoveTeam from '../src/components/LoveTeam/EditLoveTeam.vue'

Vue.use(Router)

export default new Router({
  mode: 'hash',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'listOfLoveTeam',
      component: ListOfLoveTeam
    },
    {
      path: '/loveteams',
      name: 'listOfLoveTeam',
      component: ListOfLoveTeam
    },
    {
      path: '/loveteams/create',
      name: 'CreateLoveTeam',
      component: CreateLoveTeam
    },
    {
      path: '/loveteams/edit/:id',
      name: 'EditLoveTeam',
      component: EditLoveTeam
    }
  ]
})
