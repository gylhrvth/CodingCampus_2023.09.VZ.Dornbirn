
<template>
  <div class="about">
    <h1>This is an about page</h1>
    <h2>Counter clicked {{ counterStore.count }}</h2>
  </div>
</template>
<script setup lang="ts">
import { useCounterStore } from '@/stores/counter';

const counterStore = useCounterStore()
</script>
<style>
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style>
