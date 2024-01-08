<template>
<input type="button" @click="counterStore.increment()" value="Click me"/>
<div>{{ counterStore.count }}</div>
</template>
<script setup lang="ts">
import { useCounterStore } from '@/stores/counter';

const counterStore = useCounterStore()

</script>
<style scoped>
</style>