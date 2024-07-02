<template>
  <div>Event: {{ eventId }}</div>
</template>

<script setup lang="ts">
defineProps<{ eventId: string }>();
</script>
