
<template>
  <div class="about">
    <h1>This is an about page</h1>
    <h2>Counter clicked {{ counterStore.count }}</h2>
    <div>
    <h1>Hello World!</h1>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Laborum voluptatem sit fuga voluptatum quos labore placeat eveniet, quidem possimus sunt, corporis nisi maiores adipisci id iusto reiciendis repellat fugiat nesciunt.
    Rerum unde debitis voluptates iusto est blanditiis, ex doloribus consectetur aut eligendi, tempora ut. Ducimus dolorem excepturi, nisi veniam facilis rerum, esse architecto iure dolores tenetur provident numquam quod exercitationem.
    Quos error nulla ullam sint obcaecati? Cumque, deserunt veritatis delectus ea consectetur mollitia necessitatibus pariatur quia sunt ad soluta nam ratione nihil omnis facere voluptatem tempora deleniti suscipit perferendis ipsa!</p>
  </div>
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
