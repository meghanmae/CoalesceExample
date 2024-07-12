<template>
  <c-loader-status :loaders="[event.$load, event.$save]" no-initial-content>
    <h2>
      {{ event.name }}
    </h2>

    <v-row>
      <v-col>
        <c-input :model="event" for="name" />
      </v-col>
      <v-col>
        <c-input :model="event" for="start" />
      </v-col>
      <v-col>
        <c-input :model="event" for="end" />
      </v-col>
    </v-row>

    <v-chip>
      {{ formatDate(event.start) }} - {{ formatDate(event.end) }}
    </v-chip>

    <div
      v-for="triviaQuestion in questions.$items"
      :key="triviaQuestion.$stableId"
    >
      {{ triviaQuestion.text }}
      <v-chip v-for="answer in triviaQuestion.answers" :key="answer.$stableId">
        {{ answer.text }}
      </v-chip>
    </div>

    <c-list-pagination :list="questions" />
  </c-loader-status>
</template>

<script setup lang="ts">
import { Event, TriviaQuestion } from "@/models.g";
import { EventViewModel, TriviaQuestionListViewModel } from "@/viewmodels.g";
import { format } from "date-fns";

const props = defineProps<{ eventId: string }>();

const event = new EventViewModel();
event.$dataSource = new Event.DataSources.EventWithOrgDataSource();
event.$load(props.eventId);
event.$useAutoSave();

const questions = new TriviaQuestionListViewModel();
const dataSource =
  new TriviaQuestion.DataSources.TriviaQuestionsByEventDataSource();
dataSource.eventId = props.eventId;
questions.$dataSource = dataSource;
questions.$load();
questions.$useAutoLoad();

function formatDate(date: Date | null) {
  if (date !== null) {
    return format(date, "eeee, MMMM do, yyyy h:mm a");
  }
  return "Not Set";
}
</script>
