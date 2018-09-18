<template>
  <div id="app">
    <div class="container">
      <app-nav-bar></app-nav-bar>
      <hr/>
      <router-view/>
    </div>
  </div>
</template>

<script>
import NavBar from './components/MainLayout/NavBar.vue';
export default {
  components:{
    appNavBar: NavBar
  }
}
</script>

<style>
  @import "../node_modules/bulma/css/bulma.min.css";
</style>
