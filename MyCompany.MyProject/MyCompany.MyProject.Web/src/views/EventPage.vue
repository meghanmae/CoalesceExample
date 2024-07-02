<template>
  <div>Event: {{ eventId }}</div>
</template>

<script setup lang="ts">
import { EventViewModel } from "@/viewmodels.g";

const props = defineProps<{ eventId: string }>();

const event = new EventViewModel();
event.$load(props.eventId);
</script>
